using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetardedDoggie : Dog
{
    #region Public Members

    public Rigidbody m_body;

    #endregion

    #region Public void

    #endregion

    #region System

    public override void Bark(float _volume, float _frequence)
    {
        Debug.Log(
            String.Format(
                "The dog says woof {0}{1} with a {2} pitch.",
                (_volume > 1f || _volume < .3f ? "very ":""), 
                (_volume > .5f ? "loudly":"quietly"),
                (_frequence > .5f ? "high":"low")
            )
        );
    }

    public override void Jump(float _heighCm)
    {
        m_body.AddForce(Vector3.up * .1f * _heighCm, ForceMode.Impulse);
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
