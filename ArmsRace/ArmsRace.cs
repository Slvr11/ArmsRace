using InfinityScript;

public class armsRaceMsg : BaseScript
{
    public armsRaceMsg()
    {
        HudElem info = HudElem.CreateServerFontString(HudElem.Fonts.HudBig, 0.8f);
        info.SetPoint("CENTER", "CENTER");
        info.HideWhenInMenu = true;
        info.HideIn3rdPerson = false;
        info.HideWhenInDemo = false;
        info.HideWhenDead = true;
        info.Archived = true;
        info.SetText("^1You have 10 seconds to get a kill!");
    }
}