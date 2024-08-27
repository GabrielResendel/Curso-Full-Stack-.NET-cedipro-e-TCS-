import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.css'
})
export class EventosComponent {
 public pessoas: any=[
  {
    nome: "Ronaldinho",
    nacimento: "6/06/2066"
 },
 {
  nome: "Neymar",
  nacimento: "1/02/2089"
},
{
  nome: "Caça Rato",
  nacimento: "66/09/2966"
},
];
}
