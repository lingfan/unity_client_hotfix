/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Loading
{
    public partial class UI_Loading : GComponent
    {
        public GComponent m_Pro_Load;
        public Transition m_t0;
        public const string URL = "ui://enltropwpxxk0";

        public static UI_Loading CreateInstance()
        {
            return (UI_Loading)UIPackage.CreateObject("Loading", "Loading");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Pro_Load = (GComponent)GetChildAt(1);
            m_t0 = GetTransitionAt(0);
        }
    }
}