using Nebukam.Geom;
using static Unity.Mathematics.math;

namespace Nebukam.FFD
{
    public class AnchorGroup : WorldVertexGroup<Anchor>
    {

        protected override void OnVertexAdded(Anchor v)
        {
            base.OnVertexAdded(v);
            v.diff = float3(0f);
        }

    }
}
