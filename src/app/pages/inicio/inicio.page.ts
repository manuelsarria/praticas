import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.page.html',
  styleUrls: ['./inicio.page.scss'],
})
export class InicioPage implements OnInit {

  componentes: Componente[] = [
    {
      icon: 'logo-whatsapp',
      name: 'Alert',
      redirectTo: '/alert',
    },
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
    {
      icon: 'body',
      name: 'fab',
      redirectTo: '/fab',
    },
    {
      icon: 'grid',
      name: 'grid',
      redirectTo: '/grid',
    },
    {
      icon: 'infinite',
      name: 'infinite scroll',
      redirectTo: '/infinite-scroll',
    },
    {
      icon: 'hammer',
      name: 'input ',
      redirectTo: '/input',
    },
    {
      icon: 'hammer',
      name: 'list ',
      redirectTo: '/list',
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
