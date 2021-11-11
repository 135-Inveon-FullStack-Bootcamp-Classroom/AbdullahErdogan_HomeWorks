import { FETCH_DATA } from "./actionType";

export function fetchData(memes) {
    return {
        type: FETCH_DATA,
        payload: memes,
    };
}
