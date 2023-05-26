using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add an enginner to add a machine. Have you created an engineer yet?")]

    public int MachineId { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
  }
}