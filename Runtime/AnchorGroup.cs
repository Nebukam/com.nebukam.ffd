using Unity.Mathematics;
using static Unity.Mathematics.math;
using Nebukam.Geom;

namespace Nebukam.FFD
{
    public class AnchorGroup : WorldVertexGroup<Anchor>
    {

        protected override void OnVertexAdded(Anchor v)
        {
            base.OnVertexAdded(v);
            v.diff = float3(false);
        }

    }
}
