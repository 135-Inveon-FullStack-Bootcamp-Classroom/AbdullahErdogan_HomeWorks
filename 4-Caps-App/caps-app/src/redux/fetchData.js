export default function fetchMemes(dispatch) {
    return fetch("https://api.imgflip.com/get_memes")
        .then((res) => res.json())
        .then((res) =>
            dispatch({
                type: "ITEMS",
                items: res.data.memes,
            })
        );
}
