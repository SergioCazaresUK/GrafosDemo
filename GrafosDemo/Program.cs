﻿using Grafos;

int nodo = 0;
CantGrafos grafos = new CantGrafos(6);

grafos.Arista(1, 2);
grafos.Arista(1, 3);
grafos.Arista(2, 4);
grafos.Arista(3, 5);
grafos.Arista(4, 3);
grafos.Arista(5, 1);
grafos.Arista(5, 4);

grafos.MuestraAdyacencia();