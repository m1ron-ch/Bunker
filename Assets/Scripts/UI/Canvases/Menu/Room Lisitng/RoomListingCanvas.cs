using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomListingCanvas : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform _contentParent;
    [SerializeField]
    private RoomListingContent _roomListing;

    private List<RoomListingContent> _listings = new List<RoomListingContent>();
    private Canvases _canvases;

    public void FirstInitialize(Canvases canvases)
    {
        _canvases = canvases;
    }

    public override void OnJoinedRoom()
    {
        _listings.Clear();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo info in roomList)
        {
            if (info.RemovedFromList)
            {
                int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                if (index != -1)
                {
                    Destroy(_listings[index].gameObject);
                    _listings.RemoveAt(index);
                }
            }
            else
            {
                int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                if (index == -1)
                {
                    RoomListingContent listing = Instantiate(_roomListing, _contentParent);
                    if (listing != null)
                    {
                        listing.SetRoomInfo(info);
                        _listings.Add(listing);
                    }
                }
            }
        }
    }
}
