using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Application.Interfaces;
using ItemMicroservice.Application.Parameters;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ItemMicroservice.Web.Controllers
{
    [Route("item")]
    public class ItemController(IItemService _itemService) : ApIBaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemGetDto>>> GetAllAsync([FromQuery]PaginationParameter paginationParameter, CancellationToken cancellationToken = default)
        {
            var result = await _itemService.GetAllItemsAsync(paginationParameter, cancellationToken);

            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ItemGetDto>> GetByIdAsync([FromRoute] Guid Id, CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _itemService.GetByIdAsync(Id, cancellationToken);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ItemGetDto>> CreateAsync([FromBody] ItemCreateDto createDto, CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newEntity = await _itemService.CreateAsync(createDto, cancellationToken);

            return CreatedAtAction(nameof(GetByIdAsync), new {id = newEntity.Id},newEntity );
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<ItemGetDto>> PutAsync([FromRoute] Guid id, [FromBody] ItemUpdateDto updateDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updatedEntity = await _itemService.UpdateAsync(id, updateDto);

            return Ok(updatedEntity);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<ItemGetDto>> DeleteAsync([FromRoute] Guid id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _itemService.SoftDeleteAsync(id);

            return NoContent();
        }
    }
}
