using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterController : MonoBehaviour {

    public SteamVR_TrackedObject trackedObject;
    public SteamVR_Controller.Device device;
	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
	}

    // Update is called once per frame
    void Update() {
        device = SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost));
	}
}
