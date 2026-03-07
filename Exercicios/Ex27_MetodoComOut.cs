using System;

public class Ex27_MetodoComOut {
    public bool TentarDividir(int dividendo, int divisor, out int quociente) {
        if (divisor == 0) {
            quociente = 0;
            return false;
        }
        quociente = dividendo / divisor;
        return true;
    }
}