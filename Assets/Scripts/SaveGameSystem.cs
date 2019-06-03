using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System.IO;


/// <summary>
/// todo esot esta hardcodedado
/// </summary>

public class SaveGameSystem : MonoBehaviour
{

    [Header("clases origen")]
    public AlcaldeMisiones              persistent_alcademM;
    public HerramientaSeleccionada      persistentHerramientaSeleccionada;
    public GameMaster                   persistent_game_master;
    public LogrosYMisiones              persistent_logrosMisiones;

    

    [Header("Save settings")]
    public bool loadGame=false;
    public bool Sistem_Availble = false;
    public int datos_disponiblesEn=1; // este es un level index todo hardcodeado, para igualar los valores de las clases antes de.
    public string save_file_path="sample_save.txt";



    public void UploadData()
    {

    }

    public void FetchClases()
    {

        //Del game manager las agarramos

        persistent_alcademM = GameObject.FindObjectOfType<AlcaldeMisiones>();
        persistentHerramientaSeleccionada = GameObject.FindObjectOfType<HerramientaSeleccionada>();
        persistent_game_master = GameObject.FindObjectOfType<GameMaster>();
        persistent_logrosMisiones = GameObject.FindObjectOfType<LogrosYMisiones>();
    }


    void saveJsontoDoc(string name, object obj)
    {

        StreamWriter rd = new StreamWriter(name, false);
        //convertimos todas las clases a json
        var json_str1 = JsonUtility.ToJson(obj);
        rd.Write(json_str1);
        rd.Close();
    }


    //el guardado, creara un nueva scene, convertirla en la last loaded
    public void SaveGame()
    {

        if (Sistem_Availble)
        {
            
            saveJsontoDoc("alcaldemisiones.txt", persistent_alcademM);
            saveJsontoDoc("selectedTool.txt", persistentHerramientaSeleccionada);
            saveJsontoDoc("gamemaster.txt", persistent_game_master);
            saveJsontoDoc("logrosmisiones.txt", persistent_logrosMisiones);
            Debug.LogWarning("se ha guardado el nivel");
        }
        else
        {
            Debug.LogWarning("no puedes guardar el juego causa: no estas en el nivel adecuado");
        }
       
    }

    string readJSONdoc(string namefile)
    {

        Debug.Log("el juego se ha cargado");
        StreamReader rd = new StreamReader(namefile, false);
        var doc_string = rd.ReadToEnd();
        rd.Close();
        return doc_string;
    }
    //llenamos las clases
    public void  LoadGame()
    {



        //    var skere = JsonUtility.FromJson<AlcaldeMisiones>(doc_string);
        //   persistent_alcademM = skere;
        Debug.LogWarning("se ha cargado el nivel");
        JsonUtility.FromJsonOverwrite(readJSONdoc("alcaldemisiones.txt"), persistent_alcademM);
        JsonUtility.FromJsonOverwrite(readJSONdoc("selectedTool.txt"), persistentHerramientaSeleccionada);
        JsonUtility.FromJsonOverwrite(readJSONdoc("gamemaster.txt"), persistent_game_master);
        JsonUtility.FromJsonOverwrite(readJSONdoc("logrosmisiones.txt"), persistent_logrosMisiones);
        //  persistentHerramientaSeleccionada = JsonUtility.FromJson<HerramientaSeleccionada>(doc_string);
        //   persistent_game_master = JsonUtility.FromJson<GameMaster>(doc_string);
        //  persistent_logrosMisiones = JsonUtility.FromJson<LogrosYMisiones>(doc_string);
        

    }

public void NewGame()
    {

    }
  
    public void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.LogWarning("se ha cargado un nivel!");
        if (datos_disponiblesEn == scene.buildIndex)
        {
            Debug.LogWarning("se puede guardar y se puede cargar!");
            FetchClases();
            if (loadGame) {
                LoadGame();
                loadGame = false;
            }

            Sistem_Availble = true;
        }
        else
            Sistem_Availble = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += OnLevelLoaded;

        //  LoadGame(true);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.M))
            SaveGame();

        if (Input.GetKeyDown(KeyCode.N))
            LoadGame();


    }
}
