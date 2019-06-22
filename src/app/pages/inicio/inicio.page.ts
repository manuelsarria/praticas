import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.page.html',
  styleUrls: ['./inicio.page.scss'],
})
export class InicioPage implements OnInit {

  componentes: Componente[] = [
    {
      icon: 'american-football',
      name: 'action Sheet',
      redirectTo: '/action-sheet',
    },
    {
      icon: 'appstore',
      name: 'Alert',
      redirectTo: '/alert',
    },
    {
      icon: 'beaker',
      name: 'Avatar',
      redirectTo: '/avatar',
    },
    {
      icon: 'radio-button-on',
      name: 'buttons and router',
      redirectTo: '/botones',
    },
    {
      icon: 'cash',
      name: 'card',
      redirectTo: '/card',
    },
    {
      icon: 'checkmark-circle-outline',
      name: 'check',
      redirectTo: '/check',
    },
    {
      icon: 'calendar',
      name: 'dateTime',
      redirectTo: '/date-time',
    },
  ];

  constructor() { }

  ngOnInit() {
  }

}

interface Componente {
  icon: string;
  name: string;
  redirectTo: string;

}
