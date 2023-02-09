using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingMinigame : MonoBehaviour
{
   
    //  -> fish movement 
    [Header("Fishing area")]
    [SerializeField] Transform TopB;
    [SerializeField] Transform BotB;

    [Header("FishSettings")]
    [SerializeField] Transform fish;
    [SerializeField] float smoothMotion = 3f;
    [SerializeField] float fishTimeRandomizer = 3f;
    float fishPosition;
    float fishSpeed;
    float fishTimer;
    float fishTargetPosition;

    [Header("Hook Settings")]
    [SerializeField] Transform hook;
    [SerializeField] float hookSize = .18f;
    [SerializeField] float hookSpeed = .1f;
    [SerializeField] float hookGravity = .05f;
    float hookPosition;
    float hookPullVelocity;

    [Header("Progress Bar Settings")]
    [SerializeField] Transform progressBarContainer;
    [SerializeField] float hookPower;
    [SerializeField] float progressBarDecay;
    float catchProgress;

    private void Start()
    {
        catchProgress = .3f;
    }

    private void FixedUpdate()
    {
        MoveFish();
        MoveHook();
        CheckProgress();
    }
    private void CheckProgress()
    {
        Vector3 progressBarScale = progressBarContainer.localScale;
        progressBarScale.y = catchProgress;
        progressBarContainer.localScale = progressBarScale;

        float min = hookPosition - hookSize / 3;
        float max = hookPosition + hookSize / 3;

        if (min < fishPosition && fishPosition < max)
        {
            catchProgress += hookPower * Time.deltaTime;
            if (catchProgress >= 1)
            {
                Debug.Log("You Win!");
                // Deactivate object. Gain status Fished.
            }
        }
        else
        {
            catchProgress -= progressBarDecay * Time.deltaTime;
            if (catchProgress <= 0)
            {
                Debug.Log("LOSERRRRR");
                // Deactivate object. Try again.
            }
        }
            catchProgress = Mathf.Clamp(catchProgress, 0, 1);
        }

    
    private void MoveHook()
    {
        if (Input.GetKey(KeyCode.F))
        {
            hookPullVelocity += hookSpeed * Time.deltaTime;
        }
        hookPullVelocity -= hookGravity * Time.deltaTime;

        hookPosition += hookPullVelocity;

        if (hookPosition - hookSize / 2 <= 0 && hookPullVelocity < 0)
        {
            hookPullVelocity = 0;
        }
        if(hookPosition + hookSize / 2 >= 1 && hookPullVelocity > 0)
        {
            hookPullVelocity = 0;
        }
        
        hookPosition = Mathf.Clamp(hookPosition, hookSize / 2, 1 - hookSize / 2);
        hook.position = Vector3.Lerp(BotB.position, TopB.position, hookPosition);
    }
    private void MoveFish()
    { 
        fishTimer -= Time.deltaTime;
        if(fishTimer < 0)
        {
            fishTimer = Random.value * fishTimeRandomizer;
            fishTargetPosition = Random.value;
        }
        fishPosition = Mathf.SmoothDamp(fishPosition, fishTargetPosition, ref fishSpeed, smoothMotion);
        fish.position = Vector3.Lerp(BotB.position, TopB.position, fishPosition);
    }

}
