using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{
    #region PublicVariables
    public int publicPropertySample { get; set; }
    public string publicVariableSample;
    #endregion

    #region PrivateVariables
    private string _privateVariableSample;
    #endregion

    #region Events
    public Action eventSample;
    #endregion

    #region DependencyInjection
    private void Awake()
    {

    }
    #endregion

    #region EventRegion
    private void OnEnable()
    {
        eventSample += OnEventSample;
    }

    private void OnDisable()
    {
        eventSample -= OnEventSample;
    }
    #endregion

    #region FirstFrame
    public void Start()
    {

    }
    #endregion

    #region MyMethod
    public void PublicSampleMethod()
    {

    }

    private void PrivateSampleMethod()
    {

    }
    #endregion

    #region MyEvents
    private void OnEventSample()
    {
        if (eventSample != null)
        {
            eventSample.Invoke();
        }
    }
    #endregion
}
