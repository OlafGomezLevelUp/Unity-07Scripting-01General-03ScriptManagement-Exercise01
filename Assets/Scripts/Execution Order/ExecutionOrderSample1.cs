using UnityEngine;

public class ExecutionOrderSample1 : MonoBehaviour
{
    #region PrivateReferences
    private ExecutionOrderSample2 _sample2;
    #endregion

    #region DependencyInjection
    private void Awake()
    {
        _sample2 = FindObjectOfType<ExecutionOrderSample2>();
        _sample2.GetRandomValue();
    }
    #endregion
}
