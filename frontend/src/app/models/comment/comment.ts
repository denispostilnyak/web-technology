import { User } from '../user';
import { Reaction } from '../reactions/reaction';

export interface Comment {
    id: number;
    createdAt: Date;
    author: User;
    body: string;
    isDeleted: boolean;
    reactions: Reaction[];
}
