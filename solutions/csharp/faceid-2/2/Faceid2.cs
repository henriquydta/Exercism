public class FacialFeatures(string eyeColor, decimal philtrumWidth)
{
    private string EyeColor { get; } = eyeColor;
    private decimal PhiltrumWidth { get; } = philtrumWidth;

    private bool Equals(FacialFeatures other)
    {
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((FacialFeatures)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity(string email, FacialFeatures facialFeatures)
{
    private string Email { get; } = email;
    private FacialFeatures FacialFeatures { get; } = facialFeatures;

    private bool Equals(Identity other)
    {
        return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Identity)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    private readonly HashSet<Identity> _identities;

    public Authenticator()
    {
        HashSet<Identity> identities = [];
        _identities = identities;
    }

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
    {
        var adminFacialFeatures = new FacialFeatures("green", 0.9m);
        var adminIdentity = new Identity("admin@exerc.ism", adminFacialFeatures);

        return adminIdentity.Equals(identity);
    }

    public bool Register(Identity identity) => _identities.Add(identity);

    public bool IsRegistered(Identity identity) => _identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) =>
        ReferenceEquals(identityA, identityB);
}
