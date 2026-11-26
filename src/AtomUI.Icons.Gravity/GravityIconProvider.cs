using System.Diagnostics.CodeAnalysis;
using AtomUI.Controls;

namespace AtomUI.Icons.Gravity;

public partial class GravityIconProvider : IconProvider<GravityIconKind>
{
    public GravityIconProvider()
    {
    }

    public GravityIconProvider(GravityIconKind kind) : base(kind)
    {
    }

    protected override Icon GetIcon(GravityIconKind kind)
    {
        try
        {
            return CreateIcon(kind);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Create icon {kind} failed", ex);
        }
    }

    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    protected override Type GetTypeForKind(GravityIconKind kind)
    {
        return GetIconType(kind);
    }
}
