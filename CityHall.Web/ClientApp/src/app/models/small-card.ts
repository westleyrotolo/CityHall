import { Link } from "./shared";

export interface SmallCard {
    title: string;
    subtitle?: string;
    link: Link;
    backgroundColor: string;
    textColor: string;
    icon?: string;
    image?: string
}