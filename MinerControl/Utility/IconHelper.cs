using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace MinerControl.Utility
{
    class IconHelper
    {
        private static Image GetIconFromBase64DataUri(string uri)
        {
            string base64Data = Regex.Match(uri, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            byte[] binData = Convert.FromBase64String(base64Data);

            Image image;
            using (MemoryStream stream = new MemoryStream(binData))
            {
                image = new Bitmap(stream);
            }
            return image;
        }

        public static Image Pool()
        {
            // https://www.iconfinder.com/icons/415888/complex-facilities_indoor_pool_swiming_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAJJSURBVEhL7dVJSFVRGMDx20Q0LKysCILmIgraNLkI3AiJDYsgIqSBKEg3kdSuRUQRQUFCw0IUk0C0BLNBCAya60GLiBZNErUpiyyywcb//3EvHF7Uey9euz748d6dzrnnnO98d1CUXxRjKD6ljwoQA1GC3biNb/iKa9iF+RiAvGI81qMZr/Ej8BGfM869RBPWwhH+EoOxBPtwB98RNvAAtSjHMIzEChxDN8J7HeEtOOLFcAaihwhveo8OVGMqssUsbEMnHGHYVsr5a4M3XYA3XYHT8DfhCEuxNHYV6az4V1GQtofAjErhElahoNGAcN61BnnFIrTjPrZiOIzRMHMyO3DP5BRl6IIPPUdP/N/9UYnJ8XEmUztrrIZvdw4rYVkpwj3YyDtMDI5Dh5BTTIh/jRFwd4cNtWI2nLrk3CkkU5hzTMNdhI0n3OHupxkIXyjnmIk3sDF3ubt2OubiMCx8vw17boFDd0cb1o9NWA4bPI5JWAhrknlu7XqBg3DhLXijsBPz8AgHYGJEl+Hb1cOHz8bHF+G0WPz2w0U3/Swj3vMEH7AD6/AYb2E627kdb0b6jbcgmQZ7XQarrCO0MiZFzMVcAHevdacOfh+8Zg2bAq+NxRl8QdSHRviAi+T3wDf0QafIoZqinp+DG7DBV3A9LN9jYJFLsukpHLFpHdWgF9b2E3A+n6EKe9APp+ok7ND/rtFR2JgV8zR8ITflBpi+XjuPdJgVfpVu4gjGIQkX1wS4jr1wPyRRAcu867gd4Td+I+zwf/wpougnTPC7kHcRiAIAAAAASUVORK5CYII=");
        }

        public static Image HashingAlgo()
        {
            // https://www.iconfinder.com/icons/322261/articles_collaborative_columns_commenting_communication_community_conversation_conversation-tracker_creative_friend-list_grid_journalism_newsvine_outline_powered_shape_social-media_social-network_tracker_user-columns_voting_watchlist_write_write-articles_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAEgSURBVEhL7dUxS0JRGMbxQ0HQIAlNBn2FcDBxFAqXvkLUtxDSJUkwwo8gTW1B4GLQ1BxFUKOLDung2NTW/7l6IY4cOOd2HIIe+HHuucM593154a4bd8o4xRc+9IKco4rHZOeRtcVqR4f3kV+s2meK64ID3KCOexwhU1wtUls6KOAEe3jHLpS0RRXYbfTOPs5QQg1jvEAXKzp8gitMkbmNabbwjNtkZ8wFevNH04U+ZikhU6R1BzNsQhcUsY1jtKGKvKLDVbZd/iVeMcIh9D5tY1Aa0OHKNVrzR3OHJ+SSnUdCp2gDQzxA+dUU/Sz/b06RXX7UKXKVH22KmvifouBEnyI7UafIlWhT5ErwFLl+ma68YYDPZOeR0AuCs+ILjPkGu+VnpRBDfmIAAAAASUVORK5CYII=");
        }

        public static Image EnableOne()
        {
            // https://www.iconfinder.com/icons/183316/add_plus_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFOSURBVEhLvdVNK0RRHMfxi7dAUaYseBUsPe2YlKyUJSvZsLTkLZDsbSSTKEveA0qJjbIyFOXx+5t7znRGf3fmmHv96jPn3Omc/+0+nHM7kuz0oYwplNAD5QG3OMA+7hGVQezhA19NaIzGak5LmcEzrGJZnjCNzKzgE1aBVuhqlmFmDu0U91RjFg3pRxXWhL94hF6QenZhDQytw0d9a0xoG0knBjCvg5yzgJJOoPdcbd7pQlmFJ2qHxWRSK/kKQ7XDxqy51uccZ2k3GcFw2q1nw7VhLvSjBWI9pNhYNaq6Rc32o7aSdYs2Xetz6iijTphV14a51M8xrMv7KXYdyJFuUQVF5dCfQPtH3tHGV9EJbrCjf3LOFu7S7j9sdso43mFNiPGGMZgp9IPjU+gn06cb2lteYBULaYzGak509KCWcIJrvDrqa4Euohe/JEm+AafR85Yqyw7QAAAAAElFTkSuQmCC");
        }

        public static Image DisableOne()
        {
            // https://www.iconfinder.com/icons/183317/delete_minus_remove_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAEoSURBVEhLtdVBSgMxGIbh0V5BwYIFF3qUWndaBOkVdCVu9Ah6AReuCu66kdIiepNW6MaV4MoqKKjV9xsyZQq/08RpPniSDiQ/JE1mlpLiVNHELmpYhfKMR3RxgycEZRMdfONnDo3RWM3xyj7eYBUr8oo9FOYEE1gFfGg1xzDTQpniGdU4wEzWMYY14T9eoAMyzTWsgWW0kWYDPqcl1BdqyzQ65+oXnQqaKtxIH+NkRzf5AVvp42zOXO+bc9fnM1CjC2LtYWisGmNt0bz3UakUbdGF631z6vp8hmruYC1vEW61RX3ESk9N1IuGNFewBpVxiWmiv+yUbWhZ1oQQn6jDTNQPTpaon8wsK9C75R1WsTyN0VjNCY7+qCPcY4QPR791QQ+xhj+SJL/7uS+nGreO4gAAAABJRU5ErkJggg==");
        }

        public static Image EnableAll()
        {
            // https://www.iconfinder.com/icons/183524/information_warning_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFjSURBVEhLtdVPKwVRHMbxgyxZXUUhCm+ChYViI6S8BxZybWzFgtegvAEbyV0QS5bWpPyJSFm5FBt/vs89c4rbmTN3Muepz/Sb25nzu3M6M9NkwunCDKbQgw4oz7jDHnbxhFwZwA4+8Z1BYzRW1zSUWbzBN1nIK6YRzDK+4JugEbqbJXij7qElOcJKQrVvjGiOSfxJN6rwXeCswkW1b4zzAm0Q06wD2UCbLQtJOzSn0TbtwxVcs7Sc4sSWZgTDtkyNlqpfRRm+2yzCov71OGJlQkt0icHaaTjHCWUskZULHfSA+G6vXp5d5FS1RFnvo39FDR5tGSUPanBt6yi5UYOKraNk3zXQC67o6EGrqMEttvVLwdnCvRooa9B2LSp6ca6raNGB6IdzzCFt27ZiCHrARtELX7TcmuesdlaXqB8cl6ifTJcSNvEO32S/aYzG6prc0VdpAYfQN+MjofoA8+hESoz5ASskywS/iLSaAAAAAElFTkSuQmCC");
        }

        public static Image DisableAll()
        {
            // https://www.iconfinder.com/icons/183525/error_exclamation_mark_warning_icon
            // PNG, 24x24
            return
                GetIconFromBase64DataUri(
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFaSURBVEhLtdW9LgRRGMbxgyipSBArvuI6FBIaYSNRiBtYUYhGKxRcgcIlaERHuAW1ik02IRKVj4TGx/+ZM0eWvM7uxJwn+W3e2Zw578xk5pwOF88gqlhABf1QHtDACY5xj0KZxBHe8dmCxmiszmkrS3iBNVnMMxYRzSY+YE3QDt3NBsyoe+yRnGMrp9oaI5pjHj8yjCdYJwTbCFFtjQkeoRfEdeqH7KHHl6WkF5ozazCKFR2UnFVU1EDvebiTMtOFqiaezQ7TZE4NJnydJONqMODrJBlSg1br0b+iBne+TJJbNbjxdZLU9bMO62ssQ03PXx/aNXQ3sVzklJlcLFqTxnzp3CGsK2hWZC2SA3xf9Q60npcVLZy7KvQ5K/rjCsv467XtxhT0aKYxAivaTzTPZXb0K0k3nJCkW2ZIH/bxCmuyZhqjsTqncLQrreEMepXfcqpPUUNkLXPuC57+vr6/v4N/AAAAAElFTkSuQmCC");
        }
    }
}
