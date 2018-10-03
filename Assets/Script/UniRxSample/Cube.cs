using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Cube : MonoBehaviour
{

    public float durationSecond = 1.0f;

    // Use this for initialization
    void Start()
    {
        this.UpdateAsObservable()
            .Take(TimeSpan.FromSeconds(durationSecond))
            .Subscribe(_ =>
            {
                this.gameObject.transform.Translate(Vector3.right * Time.deltaTime);
            })
            .AddTo(this);
    }
}
