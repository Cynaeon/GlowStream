using UnityEngine;

public class GoalLight : MonoBehaviour {

    public float lightDimRate;
    public float intensity;
    private Light _light;

	void Start () {
        _light = GetComponent<Light>();
	}

    void Update () {
        if (_light.intensity > 0)
            _light.intensity -= lightDimRate;
	}

    public void Activate()
    {
        if (_light)
            _light.intensity = intensity;
    }
}
