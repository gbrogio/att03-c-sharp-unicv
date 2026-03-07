using System;

public class Ex20_SobrescreverToString {
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public override string ToString() {
        return $"[Veículo] Marca: {Marca} | Modelo: {Modelo}";
    }
}