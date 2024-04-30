using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{
    [SerializeField] private Gradient HealthBarGradient;
    private float TimeToDrain = 0.25f;
    private float target=1f;
    private Image _image;
    private GameObject _camera;
    private Coroutine DrainHealthBarCoroutine;
    private void Awake()
    {
        _image = GetComponent<Image>();
    }
    private void Start()
    {
        CheckHealthBarGradientAmount();
        _camera = GameObject.FindWithTag("MainCamera");
        if (_camera == null)
        {
            Debug.LogError("No Camera component found on this GameObject.");
        }
    }
    private void Update()
    {
        transform.rotation= Quaternion.LookRotation(transform.position - _camera.transform.position);
        CheckHealthBarGradientAmount();
    }
    public void UpdateHealthBar(float maxHealth, float CurrentHealth)
    {
        target=CurrentHealth/maxHealth;
        DrainHealthBarCoroutine = StartCoroutine(DrainHealthBar());
    }

    private IEnumerator DrainHealthBar()
    {
        float fillamount=_image.fillAmount;
        float elapsedTime = 0f;
        while(elapsedTime < TimeToDrain)
        {
            elapsedTime += Time.deltaTime;
            _image.fillAmount = Mathf.Lerp(fillamount,target,(elapsedTime/TimeToDrain));
            yield return null;
        }
    }


    private void CheckHealthBarGradientAmount()
    {
        _image.color = HealthBarGradient.Evaluate(target);
    }






}//class
