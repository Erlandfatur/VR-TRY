using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsTracker : MonoBehaviour
{
public Text FPSTracker;
private int fps;
private bool isOn;
// Update is called once per frame
void Update()
{
fps = (int)(1f/Time.unscaledDeltaTime); // Get our FPS
if(isOn)
{
FPSTracker.text = fps.ToString(); // Display our FPS
}
else
{
FPSTracker.text = "";
}
}
public void fpsOn() { isOn = true; }
public void fpsOff() { isOn = false; }
}