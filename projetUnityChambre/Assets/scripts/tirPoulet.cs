using UnityEngine;
using System.Collections;

public class tirPoulet : MonoBehaviour {


	public GameObject _oeufPrefab;
	
	// Recovery manager
	public float _recoveryTime = 0.5F;
	private float _currentRecovery;

	public float _shotDistance = 1000F;
	
	public int _bulletNumber = 1;    // How much bullet the shotgun fire

	
	// Use this for initialization
	void Start()
	{

		_currentRecovery = 0;


		
		if (_oeufPrefab == null)
		{
			Debug.LogError("ERROR : Bullet prefab are not attached to Shotgun");
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		_currentRecovery -= Time.deltaTime;

		
		if (Input.GetKey(KeyCode.V) && _currentRecovery <= 0)
		{
			Fire();
			
			_currentRecovery = _recoveryTime;
		}
	}
	
	public void Fire()
	{
		//audio.Play();

			
			GameObject _oeuf = Instantiate(_oeufPrefab, transform.position, Quaternion.identity) as GameObject;
			
			_oeuf.rigidbody.AddForce((transform.forward) * _shotDistance);
		}
	}
