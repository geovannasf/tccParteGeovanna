using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLeveDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelInstrucao;
    [SerializeField] private GameObject painelGameOver;
   
   

     public void Jogar()
    {
        SceneManager.LoadScene("New Scene"); 
    }
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void instrucoesJogo()
    {
        SceneManager.LoadScene("Instrucao");
    }
    public void AbrirFases()
    {
        SceneManager.LoadScene("Fases");
    }
   
    public void FecharInstrucao()
    {
        SceneManager.LoadScene("MenuInicial");
    }
    public void FecharGameOver()
    {
        painelGameOver.SetActive(false);
    }
    
    public void SairJogo()
    {
        Debug.Log("sair do jogo");
        Application.Quit();
    }
}
