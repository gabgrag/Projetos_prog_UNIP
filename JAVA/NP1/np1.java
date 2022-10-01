/*
* Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
* Click
nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/$
{mainClassName}.java to edit this template
*/
package com.mycompany.calculator;

import javax.swing.JOptionPane;

/**
 *
 * @author USER
 */
public class Calculator {
    public static void main(String[] args) {
        int i = 1;
        do {

            String num1 = JOptionPane.showInputDialog("Digite o primeiro numero");
            double valor1 = Double.parseDouble(num1);
            String num2 = JOptionPane.showInputDialog("Digite o segundo numero");
            double valor2 = Double.parseDouble(num2);
            String opcao = JOptionPane.showInputDialog(null, "Selecione uma opcao para realizar o calculo: \n"
                    + "[1] - ADICAO \n" + "[2] - SUBTRACAO \n"
                    + "[3] - MULTIPLICACAO \n"
                    + "[4] - DIVISAO \n"
                    + "[5] - POTENCIA \n");
            int op = Integer.parseInt(opcao);
            if (op == 1) {
                double soma = valor1 + valor2;
                JOptionPane.showMessageDialog(null, "A soma é:" + soma);
            } else if (op == 2) {
                double subtracao = valor1 - valor2;
                JOptionPane.showMessageDialog(null, "A subtracao é:" + subtracao);
            } else if (op == 3) {
                double multiplicacao = valor1 * valor2;
                JOptionPane.showMessageDialog(null, "A multiplicacao é:" + multiplicacao);
            } else if (op == 4) {
                while (valor2 == 0) {
                    JOptionPane.showMessageDialog(null, "Não existe divisão por zero! \n "
                            + "Tente novamente");
                    num1 = JOptionPane.showInputDialog("Digite o primeiro numero");
                    valor1 = Double.parseDouble(num1);
                    num2 = JOptionPane.showInputDialog("Digite o segundo numero");
                    valor2 = Double.parseDouble(num2);
                }
                double divisao = valor1 / valor2;
                JOptionPane.showMessageDialog(null, "A divisao é:" + divisao);
            } else if (op == 5) {
                double potencia = Math.pow(valor1, valor2);
                JOptionPane.showMessageDialog(null, "A potencia é:" + potencia);
            } else {
                JOptionPane.showMessageDialog(null, "REFERENCIA INVALIDA! \n "
                        + "Tente novamente");
            }
        } while (i != 0);
    }

}