using Nebukam.Geom;
using Unity.Mathematics;
using static Unity.Mathematics.math;

namespace Nebukam.FFD
{
    public class Anchor : WorldVertex
    {

        /// <summary>
        /// difference between Vertex.pos & world.
        /// </summary>
        public float3 diff = float3(0f);

    }
}
