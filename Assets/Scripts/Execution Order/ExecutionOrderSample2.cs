using System.Linq;
using UnityEngine;

public class ExecutionOrderSample2 : MonoBehaviour
{
    #region PrivateVariables
    private int[] _randomValues;
    private readonly System.Random _random = new System.Random();
    #endregion

    #region DependencyInjection
    private void Awake()
    {
        GenerateRandomValues();
    }
    #endregion

    #region MyMethods
    public int GetRandomValue()
    {
        var _index = _random.Next(0, 19);
        return _randomValues[_index];
    }

    private void GenerateRandomValues()
    {
        _randomValues = Enumerable.Range(0, 20).Select(x => _random.Next(0, 300)).ToArray();
    }
    #endregion
}
