using System;
using HtxLabs.Models;
using System.Numerics;

namespace HtxLabs.Services
{
    public class ParticleSystem : IParticleSystem
    {
        private List<IParticleGroup> particleGroups = new List<IParticleGroup>();

        public IParticleGroup CreateParticleGroup(int typeId)
        {
            IParticleGroup particleGroup = new ParticleGroup(typeId);
            particleGroups.Add(particleGroup);
            return particleGroup;
        }

        public void AttachToModel(IParticleGroup particleGroup, IModel model)
        {
            // TODO: Attach the particle group to the model
        }

        public void PlaceAtLocation(IParticleGroup particleGroup, Vector3 location)
        {
            // TODO: Place the particle group at the specified location
        }

        public void PlaceInScreenSpace(IParticleGroup particleGroup)
        {
            // TODO: place the particle group in screen space
        }

        public void Scale(IParticleGroup particleGroup, float scaleFactor)
        {
            // TODO: scale the particle group by the given factor
        }

        public void Rotate(IParticleGroup particleGroup, float rotationAngle)
        {
            // TODO: rotate the particle group by the given angle
        }

        public void EndParticleGroup(IParticleGroup particleGroup)
        {
            // TODO: end the particle group early
        }
    }
}

