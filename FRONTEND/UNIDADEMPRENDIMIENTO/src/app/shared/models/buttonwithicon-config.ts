import { buttonconfig } from "./button-config";

export interface ButtonWithIconConfig extends buttonconfig {
  icon: string;
  iconColor?: string;
  typeIcon?:'material' | 'fontawesome' | 'bootstrap';
}
