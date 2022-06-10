/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.ejercicio1;

import java.util.Scanner;

/**
 *
 * @author Clever
 */
public class Ejercicio1 {

    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        
        int numHombres,numMujeres;
        int totalAlumnos;
        float porcentajeHombres;
        float porcentajeMujeres;
        
        System.out.println("Ingrese la cantidad de hombres: ");
        numHombres = teclado.nextInt();
        
        System.out.println("Ingrese la cantidad de mujeres: ");
        numMujeres = teclado.nextInt();
        
        totalAlumnos=numHombres+numMujeres;
        
        porcentajeHombres=numHombres*100f/totalAlumnos;
        porcentajeMujeres=numMujeres*100f/totalAlumnos;
        
        System.out.println("El porcentaje de hombres es: el mejor "+porcentajeHombres);
        System.out.println("El porcentaje de mujeres es: "+porcentajeMujeres);
System.out.println("El porcentaje de mujeres es: "+porcentajeMujeres);
    }
}
