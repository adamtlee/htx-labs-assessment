using System.Numerics;
using HtxLabs.Models;

namespace HtxLabs.Services
{
    public interface IParticleSystem
    {
        void AttachToModel(IParticleGroup particleGroup, IModel model);
        IParticleGroup CreateParticleGroup(int typeId);
        void EndParticleGroup(IParticleGroup particleGroup);
        void PlaceAtLocation(IParticleGroup particleGroup, Vector3 location);
        void PlaceInScreenSpace(IParticleGroup particleGroup);
        void Rotate(IParticleGroup particleGroup, float rotationAngle);
        void Scale(IParticleGroup particleGroup, float scaleFactor);
    }
}