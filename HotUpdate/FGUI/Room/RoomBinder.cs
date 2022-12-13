/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;

namespace FGUI.Room
{
    public class RoomBinder
    {
        public static void BindAll()
        {
            UIObjectFactory.SetPackageItemExtension(UI_Room.URL, typeof(UI_Room));
            UIObjectFactory.SetPackageItemExtension(UI_PlayerData.URL, typeof(UI_PlayerData));
            UIObjectFactory.SetPackageItemExtension(UI_RoomList.URL, typeof(UI_RoomList));
            UIObjectFactory.SetPackageItemExtension(UI_RoomData.URL, typeof(UI_RoomData));
        }
    }
}