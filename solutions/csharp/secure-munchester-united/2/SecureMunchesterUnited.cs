public class SecurityPassMaker
{
    public string GetDisplayName(TeamSupport support)
    {
        var type = support.GetType();
        
        if (type != typeof(Security))
            return type == typeof(Manager) || type == typeof(Chairman) ? "Too Important for a Security Pass" : support.Title;
        if (type == typeof(SecurityJunior) || type == typeof(SecurityIntern) || type == typeof(PoliceLiaison))
            return support.Title;

        return $"{support.Title} Priority Personnel";
    }
}

/**** Please do not alter the code below ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
