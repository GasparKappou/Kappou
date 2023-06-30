#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Jun 29 14:44:24 2023

@author: clinux01
"""

import pandas as pd
datos_futbol = pd.read_csv("/home/clinux01/Escritorio/GKS/datos_futbol.csv")

coinciden = 0
listaEquipos = datos_futbol["Equipo"].unique().tolist()
cantEqui = len(listaEquipos)
