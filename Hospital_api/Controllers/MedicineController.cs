using AutoMapper;
using Hospital.entities;
using Hospital.Models;
using Hospital.services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MedicineController : ControllerBase
{
    private readonly IMedicineRepository _medicine;
    private readonly IMapper _mapper;

    public MedicineController(IMapper mapper, IMedicineRepository medicine)
    {
        _mapper = mapper;
        _medicine = medicine;
    }

    [HttpGet]
    public async Task<ActionResult<MedicineMapper[]>> Get()
    {
        var medicines = await _medicine.GetAllMedicines();
        return Ok(_mapper.Map<MedicineMapper[]>(medicines));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var medicine = await _medicine.GetById(id);
        if (medicine == null)
            return NotFound();

        return Ok(_mapper.Map<MedicineMapper>(medicine));
    }

    [HttpPost]
    public async Task<IActionResult> Post(MedicineAddMapper medicineIn)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var medicine = _mapper.Map<Medicine>(medicineIn);
        await _medicine.Add(medicine);
        return CreatedAtAction(nameof(GetById), new { id = medicine.Id }, _mapper.Map<MedicineAddMapper>(medicine));
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, MedicineUpdateMapper medicineIn)
    {
        try
        {
            var medicine = await _medicine.GetById(id);
            if (medicine == null)
            {
                return NotFound(new { status = "Category not found" });
            }
            _mapper.Map(medicineIn, medicine);
            if (ModelState.IsValid)
            {
                await _medicine.SaveChangesAsync();
                return Ok(_mapper.Map<MedicineUpdateMapper>(medicine));
            }
            else
            {
                return NotFound(new { status = "Category not found" });
            }
        }
        catch (Exception)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, new { status = "server fail" });
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var medicine = await _medicine.GetById(id);
        if (medicine == null)
            return NotFound(new { status = "Medicine not found" });

        await _medicine.Delete(medicine);
        return NoContent();
    }

    [HttpPost("Search")]
    public async Task<IActionResult> SearchByName(MedicineSearchMapper? searchMapper)
    {
        var medicines = await _medicine.Search(searchMapper.Name, searchMapper.SortBy);

        var mappedMedicine = medicines.Select(p =>
        {
            var mappedMedicine = _mapper.Map<MedicineMapper>(p);
            return mappedMedicine;
        }).ToArray();

        return Ok(mappedMedicine);
    }
}

