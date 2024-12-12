using Microsoft.AspNetCore.Mvc;
using Magicvilla_VillaApi.VillaDTo;
using Magicvilla_VillaApi.Data;

namespace Magicvilla_VillaApi.Controllers
{
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiContoroller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return Ok(VillaStore.VillaList);
        }
        [HttpGet("id:int",Name ="GetVilla")]
         [ProducesResponseType(StatusCodes.Status200OK)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         [ProducesResponseType(StatusCodes.Status404NotFound)]
         //[ProducesResponseType(200,Type= typeof(VillaDto))]
         //[ProducesResponseType(200)]
         //[ProducesResponseType(200)]

        public ActionResult<VillaDto> GetVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.VillaList.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> CreateVilla([FromBody] VillaDto villaDTO)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //} 
            if (VillaStore.VillaList.FirstOrDefault(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("customError", "Villa already exist");
                return BadRequest(ModelState);
            }
            if (villaDTO == null)
            {
                return BadRequest(villaDTO);
            }
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            villaDTO.Id = VillaStore.VillaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.VillaList.Add(villaDTO);
            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.VillaList.FirstOrDefault(u=>u.Id == id);
            if (villa == null)
            {
                return NotFound();

            }
            VillaStore.VillaList.Remove(villa);
            return NoContent();
        }

        
    }
}
