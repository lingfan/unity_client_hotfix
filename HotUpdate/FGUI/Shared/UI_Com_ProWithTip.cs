/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Shared
{
    public partial class UI_Com_ProWithTip : GComponent
    {
        public GProgressBar m_Pro_Load;
        public GTextField m_Txt_LoadInfo;
        public GTextField m_Txt_LoadTip;
        public const string URL = "ui://btak13q28nuw5";

        public static UI_Com_ProWithTip CreateInstance()
        {
            return (UI_Com_ProWithTip)UIPackage.CreateObject("Shared", "Com_ProWithTip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Pro_Load = (GProgressBar)GetChildAt(0);
            m_Txt_LoadInfo = (GTextField)GetChildAt(1);
            m_Txt_LoadTip = (GTextField)GetChildAt(2);
        }
    }
}