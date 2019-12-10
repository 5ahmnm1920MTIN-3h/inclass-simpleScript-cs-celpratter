using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    // init variables
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;
    //show result in text box
    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        result.text = SubstractNumbers(a, b).ToString();
    }
    // substract numbers, return result value
    private float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        return result;
    }
}