/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.FlyFont
{
    public partial class UI_FlyFont : GComponent
    {
        public GTextField m_Tex_ValueToFall;
        public Transition m_FallingBleed;
        public const string URL = "ui://u9w4nusth2bc0";

        public static UI_FlyFont CreateInstance()
        {
            return (UI_FlyFont)UIPackage.CreateObject("FlyFont", "FlyFont");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Tex_ValueToFall = (GTextField)GetChildAt(0);
            m_FallingBleed = GetTransitionAt(0);
        }
    }
}