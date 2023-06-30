#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Jun 29 15:16:33 2023

@author: clinux01
"""
import random as rnd
import matplotlib.pyplot as plt

def hay(elemento, lista):
    encontre = False
    for i in range(len(lista)):
        if elemento == lista[i]:
            encontre = True
    return encontre
            
def coincidencia(lista):
    encontre = False
    for i in range(len(lista) - 1):
        if hay(lista[i], lista[i+1:]):
            encontre = True
    return encontre

def fechas_cumples(n):
    lista = []    
    for i in range(n):
        lista.append(rnd.randint(1, 365))    
    return lista

def chances(n, Nrep):
    contador_coincide = 0
    for i in range(Nrep):
        lista = fechas_cumples(n)
        if coincidencia(lista) == True:
            contador_coincide = contador_coincide + 1
    return contador_coincide/Nrep
""" 
v1 = []
v2 = []
v3 = []
for n in range(11):
    v1.append(n)
    v2.append(n ** 2)
    v3.append(n ** 3)
plt.plot(v1, v2, ".")
plt.show()
"""
lista_n = list(range(7, 77))
chances_para_n = []
for i in range(len(lista_n)):
    chances_para_n.append(chances(lista_n[i], 23))

plt.plot(lista_n, chances_para_n, ".")
plt.show()
n = 100
Nrep = 10000
lista = fechas_cumples(n)
print(chances(n, Nrep))

