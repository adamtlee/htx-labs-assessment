using System;
using System.Numerics;

namespace HtxLabs.Models
{
    public class ParticleGroup : IParticleGroup
    {
        public int TypeID { get; private set; }
        public int? ParticleCount { get; private set; }
        public float? ParticleLifetime { get; private set; }
        public Vector3?[] ParticleVelocities { get; private set; }

        public ParticleGroup(int typeId, int? particleCount = null, float? particleLifetime = null, Vector3?[] particleVelocities = null)
        {
            TypeID = typeId;
            ParticleCount = particleCount;
            ParticleLifetime = particleLifetime;
            ParticleVelocities = particleVelocities;
        }

    }
}

