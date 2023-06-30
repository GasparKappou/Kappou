#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Jun 29 10:27:51 2023

@author: clinux01
"""

lista = [1,2,3,4,1,3]
listaCoincide = []
def coincidencia(lista):
    for i in range(len(lista)):
        for j in range(len(lista)):
            if lista[i] == lista[j]:
                print("Si hay")
                return True
            else:
                print("No hay")
                return False
                """
    if len(listaCoincide) > 0:
        print(len(listaCoincide))
        for i in range(len(listaCoincide)):
            print(listaCoincide[i])
        return True
    else:
        return False

def encuentra(lista):
    n = 0
    burbuja = lista[n]
    n = n + 1
    for i in range(len(lista)):
        if burbuja == lista[n]:
            print("hay")
        else:
            print("n")
    burbuja = lista[n]
"""
coincidencia(lista)