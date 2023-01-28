using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
public class Grab : OVRGrabber
{
    private OVRHand hand;
    public float requiredPinchingStrength = 0.7f;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        hand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        grab();
    }
    void grab()
    {
        if (!m_grabbedObj && checkIsPinching() && m_grabCandidates.Count > 0)
        {
            GrabBegin();
        }
        else if (m_grabbedObj && !checkIsPinching())
        {
            GrabEnd();
        }
    }
    bool checkIsPinching()
    {
        float pinchStr = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        if (pinchStr > requiredPinchingStrength)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
