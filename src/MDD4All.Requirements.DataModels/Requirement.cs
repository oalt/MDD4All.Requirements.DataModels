using System.ComponentModel.DataAnnotations;

namespace MDD4All.Requirements.DataModels
{
    public class Requirement
    {
        public string GUID { get; set; } = System.Guid.NewGuid().ToString();

        public string Title { get; set; } = string.Empty;

        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = string.Empty;

        public ERequirementType Type { get; set; } = ERequirementType.FunctionalRequirement;
    }
}
