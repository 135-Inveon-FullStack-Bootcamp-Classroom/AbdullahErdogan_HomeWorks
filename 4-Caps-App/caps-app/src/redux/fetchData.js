export function fetchMemes() {
    return fetch("https://api.imgflip.com/get_memes")
        .then((res) => res.json())
        .then((res) => res);
}
