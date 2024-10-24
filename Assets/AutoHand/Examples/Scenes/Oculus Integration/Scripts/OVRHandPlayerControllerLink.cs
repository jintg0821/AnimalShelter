using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

namespace Autohand {
    [HelpURL("https://app.gitbook.com/s/5zKO0EvOjzUDeT2aiFk3/auto-hand/controller-input")]
    public class OVRHandPlayerControllerLink : MonoBehaviour{
        public AutoHandPlayer player;
        public OVRInput.Controller moveController;
        public OVRInput.Axis2D moveAxis;

        public OVRInput.Controller turnController;
        public OVRInput.Axis2D turnAxis;

        public void Update() {
            player.Move(OVRInput.Get(moveAxis, moveController));
            player.Turn(OVRInput.Get(turnAxis, turnController).x);
        }
    }
}
  