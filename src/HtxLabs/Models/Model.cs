using System;
using System.Numerics;

namespace HtxLabs.Models
{
    public class Model : IModel
    {
        public Vector3 Position { get; set; }
        public Vector3 Scale { get; set; }
        public float Rotation { get; set; }

        public Model(Vector3 position, Vector3 scale, float rotation)
        {
            Position = position;
            Scale = scale;
            Rotation = rotation;
        }
    }
}

