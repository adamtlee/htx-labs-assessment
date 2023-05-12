using System.Numerics;

namespace HtxLabs.Models
{
    public interface IModel
    {
        Vector3 Position { get; set; }
        Vector3 Scale { get; set; }
        float Rotation { get; set; }
    }
}