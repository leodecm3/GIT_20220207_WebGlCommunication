using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebGLCommunication : MonoBehaviour
{

    [SerializeField] private StarterAssetsInputs starterAssetsInputs;
    private float SecondsToStopInput = 0.5f;
    private float lookMultiplier=20;

    public void InputFromJavascript(string _inputtedString) {


        switch (_inputtedString) {
            case "W": {
                starterAssetsInputs.MoveInput(Vector2.up);
                StartCoroutine(StopInputAfterSeconds());
            }
            break;
            case "S": {
                starterAssetsInputs.MoveInput(Vector2.down);
                StartCoroutine(StopInputAfterSeconds());
            }
            break;
            case "A": {
                starterAssetsInputs.LookInput(Vector2.left * lookMultiplier);
                StartCoroutine(StopInputAfterSeconds());
            }
            break;
            case "D": {
                starterAssetsInputs.LookInput(Vector2.right * lookMultiplier);
                StartCoroutine(StopInputAfterSeconds());
            }
            break;
            case "Fire": {
                starterAssetsInputs.Fire();
            }
            break;
            case "Jump": {
                starterAssetsInputs.JumpInput(true);
                StartCoroutine(StopInputAfterSeconds());
            }
            break;
            default:
            break;
        }     

    }



    IEnumerator StopInputAfterSeconds() {
        yield return new WaitForSeconds(SecondsToStopInput);
        starterAssetsInputs.MoveInput(Vector2.zero);
        starterAssetsInputs.LookInput(Vector2.zero);
        starterAssetsInputs.JumpInput(false);
    }











}
