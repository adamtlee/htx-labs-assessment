using System.Numerics;

namespace HtxLabs.Models
{
    public interface IParticleGroup
    {
        int TypeID { get; }
        int ParticleCount { get; }
        float ParticleLifetime { get; }
        Vector3[] ParticleVelocities { get; }
    }
}