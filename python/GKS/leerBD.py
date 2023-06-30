#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Jun 29 11:35:46 2023

@author: clinux01
"""
import pandas as pd
"""
def coincidencia(listaFech):
    for i in range(len(listaFech)):
        for j in range(len(listaFech)):
            if listaFech[i] == listaFech[j]:
                return True
            else:
                return False
"""
def hay(elemento, lista):
    encontre = False
    for i in range(len(lista)):
        if elemento == lista[i]:
            encontre = True
    return encontre

def coincidencia2(lista):
    encontre = False
    for i in range(len(lista) - 1):
        if hay(lista[i], lista[i+1:]):
            encontre = True
    return encontre
    
datos_futbol = pd.read_csv("/home/clinux01/Escritorio/GKS/datos_futbol.csv")

coinciden = 0

listaEquipos = datos_futbol["Equipo"].unique().tolist()
cantEqui = len(listaEquipos)

for i in range(cantEqui):
    equipoEle = listaEquipos[i]
    datosEqui = datos_futbol.loc[datos_futbol["Equipo"] == equipoEle]
    listaFech = datosEqui["dia_mes"].tolist()
    if coincidencia2(listaFech):
        coinciden = coinciden + 1

print(coinciden)
print(coinciden/cantEqui)