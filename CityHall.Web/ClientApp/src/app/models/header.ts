import { FollowUs, Section } from "./shared";

export interface Header {
    logo?: string;
    region?: string;
    cityTitle?: string;
    citySubtitle?: string;
    supportedLanguage?: string[];
    followUs?: FollowUs[];
    sections?: Section[];
    topics?: Topic[];
}

export interface Topic {
    name: string;
}