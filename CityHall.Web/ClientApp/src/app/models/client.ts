import { Footer } from "./footer";
import { Topic } from "./header";
import { Home } from "./home";
import { FollowUs, Section } from "./shared";

export interface Client {
    id: number;
    header: Headers;
    footer: Footer;
    home: Home;
    settings: Settings;
}

export interface Settings {
    primaryColor: string;
}

